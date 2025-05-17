import {Pressable, StyleSheet, View, Text} from "react-native";

export default function Button3() {
    return (
        <Pressable>
            <View style={styles.container}>
                <Text style={styles.text}>Button3</Text>
            </View>
        </Pressable>
    )
};

const styles = StyleSheet.create({
    container: {
        display: 'flex',
        backgroundColor: 'gray',
        paddingVertical: 10,
        paddingHorizontal: 20,
        borderRadius: 15,
    },
    text : {
        color: 'blue',
        fontSize: 40,
    }
});