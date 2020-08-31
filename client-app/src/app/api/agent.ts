import axios, { AxiosResponse } from "axios";
import { IActivity } from "../Models/activity";

axios.defaults.baseURL = "http://localhost:5000/api";

const responseBody = (response: AxiosResponse) => response.data;

const sleep = (ms: number) => (response: AxiosResponse) =>
  new Promise<AxiosResponse>((resolve) =>
    setTimeout(() => resolve(response), ms)
  );

const requests = {
  get: (url: string) => axios.get(url).then(sleep(1000)).then(responseBody),
  post: (url: string, body: {}) =>
    axios.post(url, body).then(sleep(1000)).then(responseBody),
  put: (url: string, body: {}) =>
    axios.put(url, body).then(sleep(1000)).then(responseBody),
  del: (url: string) => axios.delete(url).then(sleep(1000)).then(responseBody),
};

const Activities = {
  list: (): Promise<IActivity[]> => requests.get("/mainactivities"),
  details: (id: string) => requests.get(`/mainactivities/${id}`),
  create: (activity: IActivity) => requests.post("/mainactivities", activity),
  update: (activity: IActivity) =>
    requests.put(`/mainactivities/${activity.id}`, activity),

  delete: (id: string) => requests.del(`/mainactivities/${id}`),
};

export default {
  Activities,
};
