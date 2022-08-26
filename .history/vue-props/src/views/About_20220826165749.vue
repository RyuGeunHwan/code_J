<template>
  <div class="about">
    <h1>This is an about page</h1>
    <h2>이곳은 어바웃 페이지입니다.</h2>
    <Kossie-coder title="About title" name="류근환" :propsData="message"/>
  </div>
</template>

<script src="https://cdn.jsdelivr.net/npm/vue/dist/vue.js"></script>
<script>
import KossieCoder from '@/components/KossieCoder.vue';

  components:{
    KossieCoder
  }

</script>

<style scoped>
h2{
  color : red
}
</style>