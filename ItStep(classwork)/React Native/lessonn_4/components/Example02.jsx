import {View, Text, StyleSheet, Animated} from 'react-native';
import {useRef, useEffect} from 'react';

function MoveToCenter(props) {
    const slideToCenter = useRef(new Animated.Value(500)).current;

    useEffect(() => {
        Animated.timing(
            slideToCenter,
            {
                toValue: 0,
                duration: 3000,
                useNativeDriver: true
            }
        ).start();
    }, []);

    return (
        <Animated.View style={{...styles.container, ...styles.box, transform: [{translateY: slideToCenter}] }}>
            {props.children}
        </Animated.View>
    );
}

export default function Example02() {
    return (
        <MoveToCenter style={{...styles.container, flex: 1}}>
            <Text style={{color: 'white'}}>Example02</Text>
        </MoveToCenter>
    );
};

const styles = StyleSheet.create({
    container: {
        justifyContent: 'center',
        alignItems: 'center'
    },
    box: {
        width: 150,
        height: 150,
        backgroundColor: 'black',
        borderRadius: 10
    }
});