import { FunctionComponent } from "react";

const PageLayout: FunctionComponent = ({ children }) => {
  return <div className="bg-gray-100 max-w-6xl mx-auto">{children}</div>;
};

export default PageLayout;
