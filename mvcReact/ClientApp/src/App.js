import { useEffect, useState } from "react";
import AppLayout from "./components/AppLayout";
import { Route } from "react-router";
import HomePage from "./Pages/HomePage";

const App = () => {
  const [users, setUsers] = useState([]);

  useEffect(async () => {
    const response = await fetch("api/user/GetUsers");

    if (!response.ok) {
      throw new Error(response.statusText);
    }
    const data = await response.json();

    console.log(data);
    setUsers(data);
  }, []);

  return (
    <AppLayout>
      <Route exact path="/" component={HomePage} />
    </AppLayout>
  );
};

export default App;
