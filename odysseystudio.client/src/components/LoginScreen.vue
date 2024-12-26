<script setup lang="ts">

import {ref} from 'vue';
import {useLoginStore} from '@/state/login-state';
import {useRtl} from "vuetify";

const loginStore = useLoginStore();

const email = ref('');
const password = ref('');
const rememberMe = ref(false);

const handleLogin = async () => {
  try {
    loginStore.login(
        email.value,
        password.value,
    );
    console.log('Login successful');
  } catch (error) {
    console.error('Login failed:', error);
  }
};
</script>




  <template>
    <div class="login-container">
      <h1>Login</h1>
      <form @submit.prevent="handleLogin">
        <div class="form-group">
          <label for="email">Email</label>
          <input
              id="email"
              type="email"
              v-model="email"
              placeholder="Enter your email"
          />
        </div>
        <div class="form-group">
          <label for="password">Password</label>
          <input
              id="password"
              type="password"
              v-model="password"
              placeholder="Enter your password"
          />
        </div>
        <div class="form-group">
          <label>
            <input type="checkbox" v-model="rememberMe"/>
            Remember Me
          </label>
        </div>
        <button type="submit">Login</button>
      </form>
    </div>
  </template>

  <style scoped>
    .login-container {
      max-width: 400px;
      margin: 0 auto;
      padding: 16px;
      border: 1px solid #ccc;
      border-radius: 8px;
      background-color: #f9f9f9;
    }

    h1 {
      text-align: center;
    }

    .form-group {
      margin-bottom: 16px;
    }

    label {
      display: block;
      margin-bottom: 8px;
    }

    input[type='email'],
    input[type='password'] {
      width: 100%;
      padding: 8px;
      box-sizing: border-box;
    }

    button {
      width: 100%;
      padding: 10px;
      background-color: #007bff;
      color: white;
      border: none;
      border-radius: 4px;
      cursor: pointer;
    }

    button:hover {
      background-color: #0056b3;
    }
  </style>

