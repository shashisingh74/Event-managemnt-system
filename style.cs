* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  font-family: 'Segoe UI', sans-serif;
}

body {
  background: #f0f4ff;
  overflow-x: hidden;
  position: relative;
  min-height: 100vh;
}

.container {
  max-width: 600px;
  margin: 60px auto;
  padding: 30px;
  background: white;
  border-radius: 15px;
  box-shadow: 0 0 15px rgba(0,0,0,0.1);
  position: relative;
  z-index: 2;
}

h1, h2 {
  text-align: center;
  margin-bottom: 20px;
  color: #3f51b5;
}

form {
  display: flex;
  flex-direction: column;
  gap: 15px;
}

input, button {
  padding: 12px;
  border: 1px solid #ccc;
  border-radius: 8px;
  font-size: 16px;
}

button {
  background-color: #3f51b5;
  color: white;
  cursor: pointer;
  transition: background 0.3s;
}

button:hover {
  background-color: #303f9f;
}

.event-list ul {
  list-style: none;
  margin-top: 15px;
}

.event-list li {
  background: #7888f0ff;
  margin-bottom: 10px;
  padding: 15px;
  border-radius: 10px;
  line-height: 1.5;
}

.blob {
  position: absolute;
  top: -100px;
  left: -100px;
  width: 400px;
  height: 400px;
  background: radial-gradient(circle at 30% 30%, #a5b4fc, #6366f1);
  border-radius: 50%;
  z-index: 1;
  filter: blur(100px);
  animation: float 8s ease-in-out infinite;
}

@keyframes float {
  0%, 100% {
    transform: translateY(0) translateX(0);
  }
  50% {
    transform: translateY(20px) translateX(30px);
  }
}
