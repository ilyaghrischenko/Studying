import {Image, View, StyleSheet, Text} from "react-native";

const Slide = ({ photo, title, description }) => {
    return (
        <View style={styles.container}>
            <Image source={photo} style={styles.photo} />
            <Text style={styles.title}>{title}</Text>
            <Text style={styles.description}>{description}</Text>
        </View>
    );
};

const styles = StyleSheet.create({
    container: {
        display: 'flex',
        flexDirection: 'column',
        alignItems: 'center',
        justifyContent: 'center',
        gap: 10,
    },
    photo: {
        resizeMode: 'contain',
        backgroundColor: 'lightgray'
    },
    title: {
        textAlign: 'center',
        fontSize: 20,
        fontWeight: 'bold',
    },
    description: {
        textAlign: 'center'
    }
});

export { Slide };