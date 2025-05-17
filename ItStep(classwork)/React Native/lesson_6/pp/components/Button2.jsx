import { View, Text, StyleSheet, TouchableHighlight } from 'react-native';
import { useState } from 'react';

export default function Button2() {
    const [count, setCount] = useState(0);

    return(
        <TouchableHighlight
            style={styles.container}
            onPress = {() => { count < 10 ? setCount(count + 1) : setCount(count)}}
        >
            <View>
                <Text style={styles.text}>{count}</Text>
            </View>
        </TouchableHighlight>
    )
}

const styles = StyleSheet.create({
    container: {
      backgroundColor: 'gray',
      paddingVertical: 10,
      paddingHorizontal: 20,
      borderRadius: 15
    },
    text : {
      color: 'blue',
      fontSize: 40,
      fontWeight: 'bold'
    }
  });