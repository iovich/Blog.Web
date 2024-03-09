import React from "react";
import {Route, Routes} from "react-router-dom";
import PostList from "./component/posts/PostList";

const App: React.FC = () => {

  return(
    <Routes>
      <Route path="/">
        <Route index element={<PostList/>}/>

      </Route>
    </Routes>
  );
}

export default App;