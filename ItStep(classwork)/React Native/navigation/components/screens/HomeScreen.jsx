import {View, Text, StyleSheet} from "react-native";
import {NavBar} from "../NavBar";

const HomeScreen = ({navigation}) => {
    return (
        <View style={styles.container}>
            <Text style={styles.text}>Home application screen</Text>
            <NavBar navigation={navigation} />
        </View>
    );
};

const styles = StyleSheet.create({
    container: {
        width: '100%',
        height: '100%',
        flex: 1,
        flexDirection: 'column',
        gap: '10px',
        justifyContent: 'center',
        alignItems: 'center',
        backgroundColor: 'white',
    },
    text: {
        fontSize: 25,
        marginBottom: '20px'
    }
});

export { HomeScreen };