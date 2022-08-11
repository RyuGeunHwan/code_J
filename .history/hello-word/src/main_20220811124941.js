import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
import KossieCoder from '@/components/KossieCoder.vue';

Vue.config.productionTip = false


new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')
