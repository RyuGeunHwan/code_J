<template>
  <div class="about">
    <h1>This is an about page</h1>
    <h2>이곳은 어바웃 페이지입니다.</h2>
    <KossieCoder title="About title"/>
  </div>
</template>

<script>
import KossieCoder from '@/components/KossieCoder.vue';
 
export default {
  components:{
    KossieCoder
  }
}
</script>

<style scoped>
h2{
  color : red
}
</style>