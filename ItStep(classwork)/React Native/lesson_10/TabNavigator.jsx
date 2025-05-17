import InfoScreen from "./screens/InfoScreen";
import OrdersScreen from "./screens/OrdersScreen";
import SettingsScreen from "./screens/SettingsScreen";
import React from "react";
import {createMaterialTopTabNavigator} from "@react-navigation/material-top-tabs";
import {Ionicons} from "@expo/vector-icons";

const Tab = createMaterialTopTabNavigator();

export default function TabNavigator() {
    return (
        <Tab.Navigator
            screenOptions={{
                tabBarLabelStyle: { fontSize: 14 },
                tabBarIndicatorStyle: { backgroundColor: 'green' },
                tabBarStyle: { backgroundColor: '#f2f2f2' },
                tabBarActiveTintColor: 'green',
                tabBarInactiveTintColor: 'black',
            }}
            initialRouteName="Замовлення"
        >
            <Tab.Screen name="Information" component={InfoScreen} options={{title: 'Інформація', tabBarIcon: ({color, size}) => <Ionicons name="information-circle-outline" size={20} color={color} />}} />
            <Tab.Screen name="Orders" component={OrdersScreen} options={{title: 'Замовлення'}} />
            <Tab.Screen name="Settings" component={SettingsScreen} options={{title: 'Налаштування'}} />
        </Tab.Navigator>
    );
}