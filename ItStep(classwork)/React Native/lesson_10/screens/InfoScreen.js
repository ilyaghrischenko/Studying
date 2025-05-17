import {StyleSheet, Text, View} from "react-native";
import React from "react";

const InfoScreen = () => {
    return (
        <View style={styles.screen}>
            <Text style={styles.label}>Грищенко Ілля</Text>
            <Text style={styles.label}>rhfjhf@email.com</Text>
            <Text style={styles.label}>+3801264563</Text>
        </View>
    );
};

export default InfoScreen;

const styles = StyleSheet.create({
    screen: {
        flex: 1,
        justifyContent: 'center',
        alignItems: 'center',
        padding: 20,
    },
    label: {
        fontSize: 16,
        marginBottom: 10,
    },
});