<template>
    <div id="subscription">
        <header>{{msg}}</header>
        <div id="lstSubscription" style="width:800px">
            <md-list>
                <md-subheader>Subscription</md-subheader>

                <md-list-item v-for="value in subscription" v-bind:key = "value.id">                    
                    <span class="md-list-item-text">{{value.name}}</span>
                    <md-switch v-model="value.Status" />
                </md-list-item>
                
            </md-list>
        </div>
    </div>
</template>

<script>
    import axios from "axios";

    export default {
        name: "Subscription",
        ls: "subscription",
        props: {
            msg: String
        },
        //data: () => ({
        //    subscription: [
        //        { id:1, name: "Harmony_Subscription", status: true },
        //        { id:2, name: "Domino_Item_Subscription", status: false },
        //        { id:3, name: "Domino_Item_Type_Subscription", status: true }
        //    ]
        //})
        data: () => ({
            subscription: []
        }),

        //method: {
        //    getSubscription() {
        //        axios.get('api/Subscription/GetSubscription()')
        //            .then(function (response) {
        //                if (response != null && response != undefined && response.data != null && response.data != undefined) {
        //                    if (response.data.isSuccess)
        //                        this.subscription = response.data;
        //                })
        //            .catch(error)
        //    }
        //}

        method: {
            getSubscription() {
                axios.get('http://localhost:50598/api/Subscription/GetAllSubscriptions')
                    .then(res => {
                        this.data = res.data;
                    })
            }
        }
    }
</script>

<style lang="scss" scoped>
    .full-control > .md-list {
        width: 320px;
        max-width: 100%;
        height: 400px;
        display: inline-block;
        overflow: auto;
        border: 1px solid rgba(#000, .12);
        vertical-align: top;
    }
</style>

