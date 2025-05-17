import { StatusBar } from 'expo-status-bar';
import {Image, StyleSheet, View} from 'react-native';

import logo from './assets/Logo.png';

import {Buttons} from "./components/Buttons";
import {Slider} from "./components/Slider";

export default function App() {
  return (
    <View style={styles.container}>
      <StatusBar style="auto" />

      <Image source={logo} />
      <Slider />
      <Buttons />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    gap: 40,
    backgroundColor: '#FCFBFB',
    alignItems: 'center',
    marginTop: 50,
    marginBottom: 50,
  },
});
