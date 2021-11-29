import { createRouter, createWebHistory } from 'vue-router'
//import Inlog from '../components/Inlog.vue'
import Register from '@/components/Register.vue'
import Inlog from '@/components/Inlog.vue'
import Autherized from '@/components/Autherized.vue'


const routes =[
 
  {
    path: '/Inlog',
    name: 'Inlog',
    component: Inlog
  
  },
  {
    path: '/register',
    name: 'Register',
    component: Register
  
  },
  {
    path: '/autherized',
    name: 'Autherized',
    component: Autherized
  
  }
]
const router = createRouter({
  history: createWebHistory(),
  routes
})

export default router