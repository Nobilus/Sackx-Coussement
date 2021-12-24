import "../styles/globals.css";
import React from "react";
import type { AppProps } from "next/app";
import Footer from "src/components/Footer";
import Login from "src/pages/login";
import Header from "src/components/Header";
import { Authenticated, NotAuthenticated } from "src/providers/AuthProvider";
import AppProvider from "src/providers/AppProvider";

function MyApp({ Component, pageProps }: AppProps) {
  return (
    <AppProvider>
      <Authenticated>
        <Header user={"Sander"} />
        <Component {...pageProps} />
        <Footer />
      </Authenticated>
      <NotAuthenticated>
        <Login />
      </NotAuthenticated>
    </AppProvider>
  );
}
export default MyApp;
