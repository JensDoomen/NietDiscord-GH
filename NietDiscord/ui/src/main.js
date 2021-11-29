import { createApp } from 'vue'
import App from './App.vue'
import'./assets/global.css'
import axios from 'axios'
import router from './router'
import Vue from 'vue'
import VueRouter from 'vue-router'
import { createRouter, createWebHistory } from 'vue-router'



createApp(App).use(router).mount('#app')
