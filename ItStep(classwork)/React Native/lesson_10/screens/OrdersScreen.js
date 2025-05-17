import {FlatList, StyleSheet, Text, View} from "react-native";
import React from "react";

const orders = [
    { id: '1', title: 'Куртка', status: 'Очікується' },
    { id: '2', title: 'Штани', status: 'Скасовано' },
    { id: '3', title: 'Сумка', status: 'Виконано' },
];

const OrdersScreen = () => {
    return (
        <View style={styles.screen}>
            <FlatList
                data={orders}
                keyExtractor={(item) => item.id}
                renderItem={({ item }) => (
                    <View style={styles.item}>
                        <Text style={styles.title}>{item.title}</Text>
                        <Text style={styles.status}>{item.status}</Text>
                    </View>
                )}
            />
        </View>
    );
};

export default OrdersScreen;

const styles = StyleSheet.create({
    screen: {
        flex: 1,
        padding: 20,
    },
    item: {
        backgroundColor: 'green',
        padding: 16,
        marginBottom: 10,
        borderRadius: 8,
        justifyContent: 'center',
        alignItems: 'center'
    },
    title: {
        fontSize: 16,
        fontWeight: 'bold',
    },
    status: {
        fontSize: 14,
        color: 'black',
    },
});