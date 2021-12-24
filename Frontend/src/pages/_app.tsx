import React from "react";
import type { AppProps } from "next/app";

import "../styles/globals.css";

import Footer from "../components/Footer";
import Login from "./login";
import Header from "../components/Header";
import { Authenticated, NotAuthenticated } from "./providers/AuthProvider";

function MyApp({ Component, pageProps }: AppProps) {
  return (
    <>
      <Authenticated>
        <Header user={"Sander"} />
        <Component {...pageProps} />
        <Footer />
      </Authenticated>
      <NotAuthenticated>
        <Login />
      </NotAuthenticated>
    </>
  );
}
export default MyApp;
