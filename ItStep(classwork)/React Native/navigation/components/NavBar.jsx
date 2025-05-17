import {Pressable, StyleSheet, Text, View} from "react-native";

const NavBar = ({navigation}) => {
    return (
        <View style={styles.container}>
            <Pressable style={styles.button} onPress={() => navigation.navigate('Home')}>
                <Text style={styles.text}>1</Text>
            </Pressable>
            <Pressable style={styles.button} onPress={() => navigation.navigate('Second')}>
                <Text style={styles.text}>2</Text>
            </Pressable>
            <Pressable style={styles.button} onPress={() => navigation.navigate('Third')}>
                <Text style={styles.text}>3</Text>
            </Pressable>
        </View>
    );
};

const styles = StyleSheet.create({
    container: {
        // flex: 1,
        flexDirection: 'row',
        width: '100%',
        justifyContent: 'space-around',
        alignItems: 'center',
    },
    text: {
        fontSize: 25,
        color: 'white'
    },
    button: {
        width: 40,
        height: 40,
        borderRadius: 20,
        backgroundColor: 'blue',
        justifyContent: 'center',
        alignItems: 'center'
    }
});

export { NavBar };