import { BrowserRouter as Router, Routes, Route } from "react-router-dom";

import HomePage from "../Pages/HomePage";

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
