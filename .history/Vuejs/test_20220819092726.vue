<template lang="ko">
  <div>
    <div>

      <div>
        입력 값 : {{message}}
      </div>
      <input type="text" v-model="message" />

    </div>
  </div>
</template>

<script>
export default {
  name: "CommonButton",
  props: {
    name: String,
  },
  data() {
    return {
      message: "",
    };
  },
  watch: {
    message(newValue, oldValue) {
      console.log("newValue : ", newValue);
      console.log("oldValue : ", oldValue);
    },
  },
};
</script>