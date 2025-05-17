import {View, Text, StyleSheet, Animated} from 'react-native';

import {useState, useEffect} from 'react';

function FadeInView(props) {
    const [fadeAnim] = useState(new Animated.Value(0));

    useEffect(() => {
        Animated.timing(
            fadeAnim,
            {
                toValue: 1,
                duration: 3000,
                useNativeDriver: true
            }
        ).start();
    }, []);

    return (
        <Animated.View style={{...styles.container, ...styles.box, opacity: fadeAnim}}>
            {props.children}
        </Animated.View>
    );
}

export default function Example01(props) {
    return (
        <FadeInView style={{...styles.container, flex: 1}}>
            <Text>Example01</Text>
        </FadeInView>
    );
}

const styles = StyleSheet.create({
    container: {
        justifyContent: 'center',
        alignItems: 'center'
    },
    box: {
        width: 150,
        height: 150,
        backgroundColor: 'red',
        borderRadius: 10
    }
});