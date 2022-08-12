<template>
    <div>
        <h1>{{title}}</h1>
        <p>{{  name  }}</p>
        <button @click="updateName">Change Name</button>
    </div>
</template>

<script>
export default {
    props: {
        title: {
            type : String,
            required : true 
            //required = 무조건 항상 보내줘야한다는것
        }
    },
    data(){
        return{
            name : 'Kossie Coder'
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





