import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'

// VueRouter를 사용한다고 설정 
Vue.use(VueRouter)


//Router 설정 start
const routes = [
  {
    //path : 브라우저에서 URL에 들어가는 경로
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/about',
    name: 'About',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/About.vue')
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
