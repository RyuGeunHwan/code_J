<template>
    <div>
        <p>{{  name  }}</p>
        <button @click="updateName">Change Name</button>
    </div>
</template>

<script>
export default {
    name : 'Kossie Coder',
    methods: {
        updateName(){
            this.name = 'Kossie Coder Updated'
        }
    }
    
}
</script>

<style scoped>

</style>





