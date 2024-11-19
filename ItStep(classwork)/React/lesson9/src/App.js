import { CurrentTime } from './CurrentTime';
import Field from './Field';
import { Timer2 } from './Timer2';
import './style.scss'
import { Component, useState } from 'react';


const App = () => {
  // constructor(props) {
  //   super(props);
  //   this.state = {
  //     count: 0
  //   };
  // }

  // handler() {
  //   this.setState({
  //     count: this.state.count + 1
  //   });
  // }

  // render() {
  //   return (
  //     <div className="counter">
  //       <button className="counter__btn counter__minus">-</button>
  //       <Field count="5" />
  //       <button className="counter__btn counter__plus"
  //               onClick={this.handler.bind(this)}>+</button>
  //     </div>
  //   );
  // }

  // constructor(props) {
  //   super(props);
  //   this.state = {
  //     item: 0
  //   };
  // }

  // componentDidMount() {
  //   console.log('componentDidMount');
  // }

  // componentDidUpdate() {
  //   console.log('componentDidUpdate');
  // }

  // componentWillUnmount() {
  //   console.log('componentWillUnmount');
  // }

  // render() {
  //   const {item} = this.state;

  //   return (
  //     <div className="counter">
  //       <button className="counter__btn counter__minus">-</button>
  //       <Field count={item} />
  //       <button className="counter__btn counter__plus"
  //               onClick={() => this.setState({item: item + 1})}>+</button>
  //     </div>
  //   );
  // }
  return (
    <>
      <CurrentTime />
      <br />
      <Timer2 />
    </>
  );
}

export default App;