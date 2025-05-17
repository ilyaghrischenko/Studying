import {View, Text, Button, StyleSheet} from "react-native";
import {NavBar} from "../NavBar";

const ThirdScreen = ({navigation}) => {
    return (
        <View style={styles.container}>
            <Text style={styles.text}>Third screen</Text>
            <NavBar navigation={navigation} />
        </View>
    );
};

const styles = StyleSheet.create({
    container: {
        width: '100%',
        flex: 1,
        justifyContent: 'center',
        alignItems: 'center',
        backgroundColor: 'white',
    },
    text: {
        fontSize: 25,
    }
});

export { ThirdScreen };