import 'react-native-gesture-handler';
import React from 'react';
import {NavigationContainer} from '@react-navigation/native';
import {createStackNavigator} from "@react-navigation/stack";

import {HomeScreen} from "./components/screens/HomeScreen";
import {SecondScreen} from "./components/screens/SecondScreen";
import {ThirdScreen} from "./components/screens/ThirdScreen";

const Stack = createStackNavigator();

export default function App() {
    return (
        <NavigationContainer>
            <Stack.Navigator
                initialRouteName="Home"
                screenOptions={{
                    headerStyle: {backgroundColor: 'red'},
                    headerTintColor: 'white',
                    headerTitleStyle: {fontWeight: 'bold', fontSize: 30},
                    headerTitleAlign: 'center',
                }}
            >
                <Stack.Screen
                    name="Home"
                    component={HomeScreen}
                    options={{headerTitle: 'Головна сторінка'}}
                />
                <Stack.Screen
                    name="Second"
                    component={SecondScreen}
                    options={{headerTitle: 'Друга сторінка'}}
                />
                <Stack.Screen
                    name="Third"
                    component={ThirdScreen}
                    options={{headerTitle: 'Третя сторінка'}}
                />
            </Stack.Navigator>
        </NavigationContainer>
    );
};