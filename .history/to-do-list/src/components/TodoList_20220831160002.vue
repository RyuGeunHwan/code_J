<template>
    <section>
        <ul>
            <li v-for="(todoItem, index) in propsdata" :key="todoItem">
                {{ todoItem }}
                <button type="button" v-on:click="removeTodo(todoItem, index)">삭제</button>
            </li>
        </ul>
    </section>
</template>

<script>
export default {
    props: ['propsdata'],
    methods: {
    	removeTodo(todoItem, index){
            this.$emit('removeTodo', todoItem, index);
        }
    }    
}
</script>

<style>

</style>



