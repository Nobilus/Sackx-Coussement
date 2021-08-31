import "../styles/globals.css";
import type { AppProps } from "next/app";
import { ThemeProvider } from "next-themes";
import React, { useState } from "react";
import Footer from "../components/Footer";
import Login from "./login";
import Header from "../components/Header";
import Head from "next/head";

function MyApp({ Component, pageProps }: AppProps) {
  const [isLoggedin, setIsLoggedin] = useState(true);
  return (
    <ThemeProvider attribute="class">
      <Head>
        <link rel="preconnect" href="https://fonts.googleapis.com" />
        <link rel="preconnect" href="https://fonts.gstatic.com" />
        <link
          href="https://fonts.googleapis.com/css2?family=Open+Sans:wght@300;400;700&family=Poppins:wght@300;400;500&display=swap"
          rel="stylesheet"
        />
      </Head>
      {isLoggedin ? (
        <>
          <Header user={"Sander"} />
          <Component {...pageProps} />
          <Footer />
        </>
      ) : (
        <Login />
      )}
    </ThemeProvider>
  );
}
export default MyApp;
