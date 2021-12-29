const withPWA = require("next-pwa");

module.exports = withPWA({
  reactStrictMode: true,
  distDir: "dist",
  pwa: {
    dest: "public",
    register: true,
    skipWaiting: true,
    disable: process.env.NODE_ENV === "development",
  },
});
