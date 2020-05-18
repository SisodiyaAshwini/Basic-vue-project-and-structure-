import Vue from 'vue'
import VueRouter from 'vue-router'

import HomePage from './components/Home.vue'
import SubscriptionPage from './components/Subscription.vue'
import SigninPage from './components/SignIn.vue'

Vue.use(VueRouter)

const routes = [
    { path: '/', component: HomePage },
    { path: '/Subscription', component: SubscriptionPage },
    { path: '/SignIn', component: SigninPage }
]

export default new VueRouter({ mode: 'history', routes })