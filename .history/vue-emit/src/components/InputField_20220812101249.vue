<template>
    <div>
        <label for="">Name</label>
        <input 
        type="text" 
        :value="name"
        style="padding: 30px; border:2px solid green"
        @input="updateName"
        ><br>
    </div>
</template>

<script>
export default {
    props:{
        name:{
            type: String,
            required: true
        }
    },
    methods:{
        updateName(e){
            console.log(e.target.value)
            this.$emit('update-name',e.target.value) 
            // 자식컴포넌트(Home.vue)에서 부모컴포넌트(InputField.vue)로 보내고싶은 $emit('이벤트 이름', 내용)
        }
    }
    
}
</script>

<style scoped>

</style>









