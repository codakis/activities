import React, { useState, useEffect, Fragment } from "react";
import { Header, Icon, List, Container } from "semantic-ui-react";
import axios from "axios";
import { IActivity } from "../Models/activity";
import { NavBar } from "../../features/nav/NavBar";
import { ActivityDashboard } from "../../features/activities/dashboard/ActivityDashboard";

const App = () => {
  const [activities, setActivities] = useState<IActivity[]>([]);

  useEffect(() => {
    axios
      .get<IActivity[]>("http://localhost:5000/api/mainactivities")
      .then((response) => {
        setActivities(response.data);
      });
  }, []);

  return (
    <Fragment>
      <NavBar />
      {/* <Header as="h2" icon>
        <Icon name="users" />
        Activities
        <Header.Subheader>
          Check the main activities in near areas.
        </Header.Subheader>
      </Header> */}
      <Container style={{ marginTop: "7em" }}>
        <ActivityDashboard activities={activities} />
      </Container>
    </Fragment>
  );
};
export default App;
