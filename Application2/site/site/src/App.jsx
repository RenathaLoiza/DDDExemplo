import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import NavBar from './NavBar'
import Index from './pages/listar-veiculos/index'

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
          <div>
              
              <NavBar></NavBar>
              <Index></Index>
      </div>
     
    </>
  )
}

export default App
