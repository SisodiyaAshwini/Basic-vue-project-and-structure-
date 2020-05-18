<template>
    <div id="signin">
        <md-field md-clearable>
            <label>Username</label>
            <md-input v-model="username"></md-input>
        </md-field>

        <md-field>
            <label>Password </label>
            <md-input v-model="password" type="password"></md-input>
        </md-field>
    </div>
</template>

<script>
    export default {
        name: 'SignIn',
        data: () => ({
            username: 'Ashwini',
            password: 'password'
        })
    }
</script>

<style lang="scss" scoped>
    .md-field:last-child {
        margin-bottom: 40px;
    }
</style>