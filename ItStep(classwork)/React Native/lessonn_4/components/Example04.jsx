import {Animated, View, Button, Image, StyleSheet, Easing} from "react-native";
import { useRef, useState, useEffect } from "react";

import spinner from "../assets/spinner.png";

const Example04 = () => {
    const [rotating, setRotating] = useState(false);

    const rotateAnim = useRef(new Animated.Value(0)).current;
    const rotation = useRef(null);
    const rotate = rotateAnim.interpolate({
        inputRange: [0, 1],
        outputRange: ['0deg', '360deg']
    });

    const startRotation = () => {
        if (rotating) return;

        setRotating(true);
        rotation.current = Animated.loop(
            Animated.timing(
                rotateAnim,
                {
                    toValue: 1,
                    duration: 3000,
                    useNativeDriver: true,
                    easing: Easing.linear
                }
            )
        );

        rotateAnim.setValue(0);
        rotation.current.start();
    };

    const stopRotation = () => {
        if (!rotating) return;

        setRotating(false);
        rotateAnim.stopAnimation();
    };

    return (
        <View>
            <Animated.View style={{alignItems: 'center', marginBottom: 20, transform: [{rotate: rotate}]}}>
                <Image
                    source={spinner}
                    style={{width: 100, height: 100}}
                />
            </Animated.View>
            <View style={styles.btn}>
                <Button title='Start' onPress={startRotation} />
                <Button title='Stop' onPress={stopRotation} />
            </View>
        </View>
    );
};

const styles = StyleSheet.create({
    btn: {
        flexDirection: 'row',
        justifyContent: 'space-between',
        gap: 10
    }
});

export default Example04;