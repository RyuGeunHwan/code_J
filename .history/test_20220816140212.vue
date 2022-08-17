<template>
    <h1 v-bind:class="{active : isActive}" @click="activate">
        Hello Vue.js!(isActive = {{ isActive }})
    </h1>

    <h1 :class="{active : isActive}" @click="activate">
        Hello Vue.js!(isActive = {{ isActive }})
    </h1>
</template>

<script>
export default {
    
}
</script>

<style scoped>

</style>



