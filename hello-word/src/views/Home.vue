<template>
  <div>
    <h1>This is Home page</h1>
    <KossieCoder></KossieCoder>
  </div>
</template>

<script>
// KossieCoder를 가져오기 @(src를 의미함)/components/KossieCoder.vue 여기에서
import KossieCoder from '@/components/KossieCoder.vue';

export default{
  components : {
    KossieCoder
  },
  data(){
    return{ // Object를 return
       name : 'Kossie Coder'
    }
  }
}
</script>

<style scoped>
/* 현재 페이지의 h1태그만 스타일 적용 */
h1{
  color : red;
}
</style>



















