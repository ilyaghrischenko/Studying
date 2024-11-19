import { Component } from "react";

class Field extends Component {
    constructor(props) {
        super(props);
        this.props = props;
    }

    render() {
        return (<div className = "counter__field">{this.props.count}</div>);
    }
};

export default Field;