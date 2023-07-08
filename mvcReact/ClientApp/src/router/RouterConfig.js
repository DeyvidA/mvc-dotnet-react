import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import HomePage from "../Pages/HomePage.js";

const RouterConfig = () => {
  return (
    <Router>
      <Routes>
        <Route>
          <Route path="/" element={<HomePage />} />
        </Route>
      </Routes>
    </Router>
  );
};

export default RouterConfig;
