import { Component } from "react";

class Timer2 extends Component {
    constructor(props) {
        super(props);
        this.state = {data:new Date()};

        this.intervalId = null;
    }
    
    tick = () => {
        this.setState({data:new Date()});
    }

    componentDidMount() {
        this.intervalId = setInterval(this.tick, 1000);
    }

    componentWillUnmount() {
        clearInterval(this.intervalId);
    }

    render() {
        return (<div>class: {this.state.data.toLocaleTimeString()}</div>);
    }
};

export {Timer2};