import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, View } from 'react-native';
import {Annotation} from "./Annotation";

export default function App() {
  return (
    <View style={styles.container}>
      <StatusBar style="auto" />

      <Annotation />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
});
