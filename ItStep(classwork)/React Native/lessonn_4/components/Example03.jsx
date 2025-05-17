import {View, Text, StyleSheet, Animated, Easing} from "react-native";
import {useRef, useEffect} from "react";

const RotateBlock = (props) => {
    const rotateAnim = useRef(new Animated.Value(0)).current;
    const spin = rotateAnim.interpolate({
        inputRange: [0, 1],
        outputRange: ['0deg', '360deg']
    });

    useEffect(() => {
        Animated.loop(
            Animated.timing(
                rotateAnim,
                {
                    toValue: 1,
                    duration: 3000,
                    useNativeDriver: true,
                    easing: Easing.linear
                }
            )
        ).start();
    }, []);

    return (
        <Animated.View style={{...styles.container, ...styles.box, transform: [{rotate: spin}]}}>
            {props.children}
        </Animated.View>
    );
};

const Example03 = () => {
    return (
        <RotateBlock>
            <Text style={{color: 'white'}}>Example03</Text>
        </RotateBlock>
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
        backgroundColor: 'blue',
        borderRadius: 10
    }
});

export default Example03;