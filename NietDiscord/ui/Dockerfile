# FROM ubuntu

# MAINTAINER jensdoomen pal <457543@student.fontys.nl>

# RUN apt-get update

# CMD ["echo", "Hello World...! from my first docker image!"]

FROM node:lts-alpine as build-stage

RUN npm install -g http-server

WORKDIR /app

COPY package*.json ./

RUN npm install

COPY . .

RUN npm run build

EXPOSE 8080
CMD ["http-server", "dist"]
