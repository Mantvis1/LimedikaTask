const { env } = require('process');

const target = 'https://localhost:44347';

const PROXY_CONFIG = [
  {
    context: [
      "/Client",
    ],
    target,
    secure: false
  }
]

module.exports = PROXY_CONFIG;
