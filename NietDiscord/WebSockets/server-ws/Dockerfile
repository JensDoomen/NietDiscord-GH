FROM node:carbon
RUN npm install -g nodemon
WORKDIR /usr/src/app/server-ws
COPY package*.json ./
RUN npm install
COPY . .
WORKDIR /usr/src/app/server-ws
EXPOSE 5002
CMD [ "server.js" ]
