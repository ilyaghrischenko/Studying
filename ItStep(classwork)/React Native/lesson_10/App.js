import React from 'react';
import { NavigationContainer } from '@react-navigation/native';
import {SafeAreaView, Text, View, StyleSheet, StatusBar} from 'react-native';
import TabNavigator from "./TabNavigator";

export default function App() {
    return (
        <NavigationContainer>
            <StatusBar />

            <SafeAreaView style={{ flex: 1 }}>
                <View style={styles.header}>
                    <Text style={styles.headerText}>Особистий кабінет</Text>
                </View>

                <TabNavigator />
            </SafeAreaView>
        </NavigationContainer>
    );
}

const styles = StyleSheet.create({
    header: {
        padding: 16,
        backgroundColor: 'green',
        alignItems: 'center',
        borderBottomWidth: 1,
        borderBottomColor: '#ddd',
    },
    headerText: {
        fontSize: 25,
        fontWeight: 'bold',
    },
    screen: {
        flex: 1,
        alignItems: 'center',
        justifyContent: 'center',
        padding: 20,
    },
    text: {
        fontSize: 19,
    },
});