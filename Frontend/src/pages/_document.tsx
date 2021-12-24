import Document, { Html, Head, Main, NextScript } from "next/document";

class MyDocument extends Document {
  render() {
    return (
      <Html>
        <Head>
          <title>Sacx-Coussement</title>
          <link rel="preconnect" href="https://fonts.googleapis.com" />
          <link rel="preconnect" href="https://fonts.gstatic.com" />
          <link
            href="https://fonts.googleapis.com/css2?family=Open+Sans:wght@300;400;600;700&family=Poppins:wght@300;400;500&display=swap"
            rel="stylesheet"
          />
        </Head>
        <body className="bg-gray-100 h-screen flex flex-col justify-between">
          <Main />
          <NextScript />
        </body>
      </Html>
    );
  }
}

export default MyDocument;
