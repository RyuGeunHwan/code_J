<template>
<div id="app">
  <Button @click="showModal = true"> 모달열기 </Button>
  <!-- 아래와 같이 부모는 자식 컴포넌트에 v-bind 또는 : 를 통해 props를 넘길 수 있습니다. -->
  <!-- 함수의 경우 @넘길함수이름="정의한 함수 이름" 을 통해 자식에게 부모 함수를 넘깁니다. -->
  <Modal
    :show="showModal"
    :point="this.point"
    @close="handlePointStorageClose"
  />
</div>
</template>

<script>
import Modal from '@/components/vue-test';
export default{
  methods: {
    handlePointStorageClose(close){
      this.showShortageModal = close;
    }
  },
  data(){
    return {
      showModal: false,
      point: 1000
    }
  },
  components: {
    Modal
  }
}
</script>