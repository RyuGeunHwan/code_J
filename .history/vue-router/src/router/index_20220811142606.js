import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'

// VueRouter를 사용한다고 설정 
Vue.use(VueRouter)


//Router 설정 start
const routes = [
  {
    //path : 브라우저에서 URL에 들어가는 경로 ex) http://localhost:8080/
    path: '/',
    name: 'Home',
    // component : import한 component를 사용할 수 있게끔 넣어주는것.
    component: Home
  },
  {
    //path : 브라우저에서 URL에 들어가는 경로 ex) http://localhost:8080/about
    path: '/about',
    name: 'About',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.

    // 전역으로 import하지 않고 About.vue를 불러옴과 동시에 component를 넣었다.
    component: () => import(/* webpackChunkName: "about" */ '../views/About.vue')
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
