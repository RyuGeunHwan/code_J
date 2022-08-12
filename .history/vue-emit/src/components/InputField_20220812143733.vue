<template>
    <div>
        <label for="">Name</label>
        <input 
        type="text" 
        :value="value"
        style="padding: 30px; border:2px solid green"
        @input="$emit('input', $event.target.value)"
        ><br>
    </div>
</template>



<script>
export default {
    props:{
        value:{
            type: String,
            required: true
        }
    },
    // methods:{
    //     updateName(e){
    //         console.log(e)
    //         console.log(e.target.value)
    //         this.$emit('update-name',e.target.value); 
    //         // 자식컴포넌트(InputField.vue)에서 부모컴포넌트(Home.vue)로 보내고싶은 $emit('이벤트 이름', 내용)
    //     }
    // }
    
}
</script>

<style scoped>

</style>









