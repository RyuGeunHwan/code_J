<template>
    <div>
        <h1>{{title}}</h1>
        <h3>{{name}}</h3>
        <!-- <p>{{  name  }}</p> -->
        <button @click="updateName">Change Name</button>
    </div>
</template>

<script>
export default {
    props: {
        title: {
            type : String,
            required : false ,
            //required = 무조건 항상 보내줘야한다는것
            default: 'default title' 
            //default : 자식컴포넌트에서 props를 받아오지 않아도 default로 보여줌.
        },
        name: {
            type : String,
            required : false,
            //required = 무조건 항상 보내줘야한다는것
            default: 'Ryu geun hwan' 
            //default : 자식컴포넌트에서 props를 받아오지 않아도 default로 보여줌.
        }
    },
    data(){
        return{
            // name : 'Kossie Coder'
        }
    },
    methods: {
        updateName(){
            this.name = 'Kossie Coder Updated'
        }
    }
    
}
</script>

<style scoped>

</style>





