// Firebase configuration
const firebaseConfig = {
  apiKey: "AIzaSyDDUZ-myrWxa-TKi0LQpOtT-XpjbN7SWZU",
  authDomain: "decibel-note-firebase.firebaseapp.com",
  projectId: "decibel-note-firebase",
  storageBucket: "decibel-note-firebase.appspot.com",
  messagingSenderId: "137498558969",
  appId: "1:137498558969:web:4d29368b062c86dc557d28",
  measurementId: "G-6S7E9CR9GN"
};

// Initialize Firebase
firebase.initializeApp(firebaseConfig);

// Initialize services
const auth = firebase.auth();

// Elements
const loginDiv = document.getElementById('Login');
const registerDiv = document.getElementById('Register');
const loginButton = document.getElementById('LoginButton');
const registerButton = document.getElementById('register-button');
const changeToRegisterButton = document.getElementById('changeToRegisterButton');
const changeToLoginButton = document.getElementById('changeToLoginButton');
const emailInput = document.getElementById('Email');
const passwordInput = document.getElementById('PassWord');
const registerEmailInput = document.getElementById('register-email');
const registerPasswordInput = document.getElementById('register-password');

// Toggle to registration form
changeToRegisterButton.addEventListener('click', () => {
  loginDiv.classList.add('hidden');
  registerDiv.classList.remove('hidden');
});

// Toggle to login form
changeToLoginButton.addEventListener('click', () => {
  registerDiv.classList.add('hidden');
  loginDiv.classList.remove('hidden');
});

// Handle login
loginButton.addEventListener('click', () => {
  const email = emailInput.value;
  const password = passwordInput.value;

  auth.signInWithEmailAndPassword(email, password)
    .then(userCredential => {
      console.log('User signed in:', userCredential.user);
      window.location.href = 'Decibel Editor.html';
    })
    .catch(error => {
      console.error('Error signing in:', error);
      alert('Error signing in: ' + error.message);
    });
});

// Handle registration
registerButton.addEventListener('click', () => {
  const email = registerEmailInput.value;
  const password = registerPasswordInput.value;

  auth.createUserWithEmailAndPassword(email, password)
    .then(userCredential => {
      console.log('User registered:', userCredential.user);
      window.location.href = 'Decibel Editor.html';
    })
    .catch(error => {
      console.error('Error registering:', error);
      alert('Error registering: ' + error.message);
    });
});
