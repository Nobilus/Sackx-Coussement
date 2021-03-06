const withPWA = require("next-pwa");

module.exports = withPWA({
  reactStrictMode: true,
  webpack5: true,
  pwa: {
    dest: "public",
    register: true,
    skipWaiting: true,
    disable: process.env.NODE_ENV === "development",
    mode: "production",
  },
  i18n: {
    locales: ["nl-BE"],
    defaultLocale: "nl-BE",
  },
});
