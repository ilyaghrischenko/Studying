import {StyleSheet, Text, View, Switch} from "react-native";
import React, { useState } from "react";

const SettingsScreen = () => {
    const [isDarkTheme, setIsDarkTheme] = useState(true);
    const [isNotificationsEnabled, setIsNotificationsEnabled] = useState(false);

    return (
        <View style={styles.screen}>
            <View style={styles.row}>
                <Text style={styles.label}>Темна тема</Text>
                <Switch
                    value={isDarkTheme}
                    onValueChange={setIsDarkTheme}
                />
            </View>
            <View style={styles.row}>
                <Text style={styles.label}>Сповіщення</Text>
                <Switch
                    value={isNotificationsEnabled}
                    onValueChange={setIsNotificationsEnabled}
                />
            </View>
        </View>
    );
};

export default SettingsScreen;

const styles = StyleSheet.create({
    screen: {
        flex: 1,
        padding: 20,
    },
    row: {
        flexDirection: 'row',
        justifyContent: 'space-between',
        alignItems: 'center',
        marginBottom: 20,
        backgroundColor: 'green',
        borderRadius: 10,
    },
    label: {
        fontSize: 16,
    },
});