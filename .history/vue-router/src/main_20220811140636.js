import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'

Vue.config.productionTip = false

//Vue 인스턴스 생성
new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')
